# samp-base-launcher
SA:MP Launcher Class menggunakan C#

Kalau ga ngerti gabisa bantu, coba research sendiri :P

## Contoh

```c#

// Taruh ini sebelum public MainForm atau public Form1
Laucher launcher = new Launcher("ip-kamu.net:7777 "); // selalu tinggalkan spasi paling ujung

public Button1_Clicked(object sender, EventArgs e) {
    try {
        launcher.GetPath();
        launcher.Start("Nama_Kalian", "password_server");
    }
    catch {
        // Error message
    }
}

```
