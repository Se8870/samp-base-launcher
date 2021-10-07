# samp-base-launcher
SA:MP Launcher Class menggunakan C#

Kalau ga ngerti gabisa bantu, coba research sendiri :P

## Contoh

```c#

// Taruh ini sebelum public MainForm atau public Form1
Laucher launcher = new Launcher();

public Button1_Clicked(object sender, EventArgs e) {
    try {
        launcher.Start("ip-kamu.net:7777", "Nama_Kalian", "password_server");
    }
    catch {
        // Error message
    }
}

```
