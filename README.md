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
    
    try {
        launcher.StartSA("ip-kamu.net:7777", "Nama_Kalian", "password_server");
    }
    catch {
        // Error message
    }
}
```
