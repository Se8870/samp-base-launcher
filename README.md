# samp-base-launcher
SA:MP Launcher Class menggunakan C#


## List Fungsi
```c#
public String GetSAPath();
public bool StartSA(String ipAddress, String userName, String serverPassword);
public bool CloseSA();
```



## Contoh
```c#
public Button1_Clicked(object sender, EventArgs e) {
    Laucher launcher = new Launcher();
    
    if (!launcher.StartSA("ip-kamu.net:7777", "Nama_Kalian", "password_server"))
    {
        MessageBox.Show("Launcher tidak bisa membuka SA, mungkin ip atau path nya salah. Kontak administrator untuk info lebih lanjut", "Launcher Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

}
```
