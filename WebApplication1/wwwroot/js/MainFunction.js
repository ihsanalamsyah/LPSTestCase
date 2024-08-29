function handleFileChange(event) {
    console.log("filed");
    var data = new FormData();
    var fileName = event.target.files[0].name;
    if ($("#fileID").val().trim() != "") {
        var files = $("#fileID").get(0).files;
        if (files.length > 0) {
            if (files[0].size <= 1073741824) {
                if ((files[0].type).toLowerCase().indexOf("xls") > -1
                    || (files[0].name).toLowerCase().indexOf(".xls") == ((files[0].name).length - 4)) {
                    data.append("pDataFile", files[0]);
                    data.append("pFileName", fileName);
                    $.ajax({
                        type: "POST",
                        route: 'UploadFile',
                        data: data,
                        contentType: false,
                        processData: false,
                        success: function (result) {
                            if (result.status == true) {
                                fileName = "";
                                $("#fileID").val('');

                            } else {
                                alert(result.message);
                            }
                        },
                        error: function (xhr, ajaxOptions, thrownError) {
                            alert('System / Server error', document.location, 'Upload File', thrownError);
                        }
                    });
                }
                else {
                    alert("Please upload .csv file only");
                }
            }
            else {
                alert("File size cannot exceed 1GB");
            }
        }
        else {
            alert("Please select file to upload");
        }
    }
}