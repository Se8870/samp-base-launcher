/*
 * Launcher Class v1.0
 * Created by Kirima2nd.
 * Date: 4/26/2021
 * 
 * 
 * Dilarang diperjual belikan, diomelin diluar tanggung jawab
 * Mau disebar, mau di pake sendiri silahkan, in fact this is open source lol
 * 
 */
 
using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;


public class Launcher
{
	private string ip = null;
	private string sa_path = null;
	
	public Launcher(string ipAddress)
	{
		// init when declared
		if (sa_path == null) {
			sa_path = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP").GetValue("gta_sa_exe").ToString();
			sa_path = sa_path.Substring(0, sa_path.LastIndexOf("\\") + 1);
		}
		ip = ipAddress;
	}
	
	/// <summary>
	/// Menjalankan samp.exe dengan argumen name dan password_server
	/// </summary>
	/// <param name="name">Bertugas untuk memasukkan nama ke registry</param>
	/// <param name="password_server">Bertugas untuk memasukkan password_server ke Process</param>
	/// <returns>
	/// 	False - Jika IP dari Launcher(string ipAddress) kosong
	/// </returns>
	/// <returns>
	/// 	False - Jika sa_path kosong
	/// </returns>
	/// <returns>
	/// 	True - Jika berhasil dijalankan
	///	</returns>
	public bool Start(string name, string password) {
		if (string.IsNullOrEmpty(ip)) {
			return false;
		}
		
		if (string.IsNullOrEmpty(sa_path)) {
		    	return false;
		}

		Registry.CurrentUser.OpenSubKey("Software\\SAMP", writable: true).SetValue("PlayerName", name);
		Process.Start(sa_path + "samp.exe", ip + password);
		return true;
	}
	/// <summary>
	/// Untuk menutup proses gta sa
	/// </summary>
	/// <returns>
	/// 	False - Jika tidak ada yang berjalan
	/// </returns>
	/// <returns>
	/// 	True - Jika ada yang berjalan, maka otomatis akan dimatikan
	/// </returns>
	public bool Close() {
		Process[] processes = Process.GetProcessesByName("gta_sa.exe");
		if (processes.Length > 0) {
		    processes[0].CloseMainWindow();
		    return true;
		}
		return false;
	}
	/// <summary>
	/// Mengambil path dari SA:MP yang diambil dari Registry Key
	/// </summary>
	/// <returns>
	/// 	gta sa path yang ada SA:MP nya
	/// </returns>
	public string GetPath() {
		return sa_path;
	}
}
