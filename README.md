# test

1. Declare class application, dan protected isi string shieldLastRun.
bisa dilakukan lebih mudah buat method untuk return string application?.protected?.shieldLastRun;

2. Dalam Method GetInfo() parameter out string StringOutInfo untuk menambahkan return value dan dapat dipanggil saat run Method.

3. Buat private string Os {get; set;} didalam class Laptop artinya hanya dapat memanggil Os di dalam class Laptop saja. Maka perlu menambahkan Method GetOs di class tersebut. Sehingga dapat memanggil Os yang sudah di declare di class Laptop.

4. Hapus while(true){} karena akan membuat loop tidak unlimited (tak terhingga) dan menghapus argument dalam Method Main(string[] args) karena tidak digunakan parameter tersebut. Dan buat Console untuk melihat isi List tersebut dengan SKU : Guid(), Price: i.

5. Hapus code yang tidak perlu dan membuat lambat program. Hapus whie(true){} dan argument Method Main(string[] args) karena tidak perlu. Ditambahkan trigger event dalam class EventPublisher dengan memanggil Method RaiseEvent(). Pendaftaran Publish kedalam Subscribe dilakukan di dalam class EventSubscriber untuk mudah melihat code dan tidak sepenuhnya di Method Main. Dengan mendaftarkan Method OnMyEvent tanpa parameter karena tidak dibutuhkan. Tapi di dalam Method OnMyEvent dibiarkan parameter karena defaultnya seperti itu.

6. Hapus code yang tidak perlu dan membuat lambat program. Hapus while(true){} dan argument Method Main(string[] args) karena tidak perlu. Dan tambahkan class RootNode untuk men-store TreeNode dan Nama Node tersebut. Dan tambahkan Method parameter TreeNode dan string untuk Add kedalam class RootNode. Dan implement Method tersebut pada code sehingga rootNode.AddChild(newNode) diubah menjadi rootNode.AddRootChild(newNode, "Nama Node").

7. Menambahkan class Oran dan mengisi kedalam class cache. Buat Method AddCache dengan object Oran. Dalam Method Main ReadLine untuk input nama orang dan masukkan kedalam object class Oran. Ubah Method Add dengan AddCache(i, orang). GetCache dan Console WriteLine hasilnya.
