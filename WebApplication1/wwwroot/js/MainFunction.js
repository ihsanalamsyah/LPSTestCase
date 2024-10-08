﻿function handleFileChangeXlsx(event) {
    console.log("filed");
    var data = new FormData();
    var fileName = event.target.files[0].name;
    if ($("#fileIDXlsx").val().trim() != "") {
        var files = $("#fileIDXlsx").get(0).files;
        if (files.length > 0) {
            if (files[0].size <= 1073741824) {
                if ((files[0].type).toLowerCase().indexOf("xls") > -1
                    || (files[0].name).toLowerCase().indexOf(".xls") == ((files[0].name).length - 4)) {
                    data.append("pDataFile", files[0]);
                    data.append("pFileName", fileName);
                    $.ajax({
                        type: "POST",
                        route: 'UploadFileXlsx',
                        data: data,
                        contentType: false,
                        processData: false,
                        success: function (result) {
                            if (result) {
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

function handleFileChangePdf(event) {
    console.log("filed");
    var data = new FormData();
    var fileName = event.target.files[0].name;
    if ($("#fileIDPdf").val().trim() != "") {
        var files = $("#fileIDPdf").get(0).files;
        if (files.length > 0) {
            if (files[0].size <= 1073741824) {
                if ((files[0].type).toLowerCase().indexOf("pdf") > -1
                    || (files[0].name).toLowerCase().indexOf(".pdf") == ((files[0].name).length - 4)) {
                    data.append("pDataFile", files[0]);
                    data.append("pFileName", fileName);
                    $.ajax({
                        type: "POST",
                        route: 'UploadFilePdf',
                        data: data,
                        contentType: false,
                        processData: false,
                        success: function (result) {
                            if (result) {
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
                    alert("Please upload .pdf file only");
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