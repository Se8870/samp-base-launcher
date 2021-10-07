/*
 * Launcher Class v2.1
 * Created by Kirima2nd.
 * Date: 4/26/2021
 * 
 * 
 * Dilarang memperjual-belikan kode ini tanpa seizin dari pembuat.
 */
 
using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;

public class Launcher
{
	private String _path = null;
	public Launcher()
	{
		// init when declared
		_path = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP").GetValue("gta_sa_exe").ToString();
		_path = sa_path.Substring(0, sa_path.LastIndexOf("\\") + 1);
	}
	
	/// <summary>
	/// Mengambil path dari SA:MP yang diambil dari Registry Key
	/// </summary>
	/// <returns>
	/// 	gta sa path yang ada SA:MP nya
	/// </returns>
	public String GetSAPath() {
		return _path;
	}
	
	/// <summary>
	/// Menjalankan samp.exe dengan argumen name dan password_server
	/// </summary>
	/// <param name="ip">IP Address Server yang dituju</param>
	/// <param name="name">Bertugas untuk memasukkan nama ke registry</param>
	/// <param name="password_server">Bertugas untuk memasukkan password_server ke Process</param>
	/// <returns>
	/// 	False - Jika IP Address kosong atau jika GTA SA Path kosong
	/// </returns>
	/// <returns>
	/// 	True - Jika berhasil dijalankan
	///	</returns>
	public bool StartSA(String ipAddress, String userName, String serverPassword) {
		if (string.IsNullOrEmpty(ipAddress)) {
			return false;
		}
		
		if (string.IsNullOrEmpty(GetPath())) {
		    	return false;
		}
		
		try {
			Registry.CurrentUser.OpenSubKey("Software\\SAMP", writable: true).SetValue("PlayerName", userName);
			Process.Start(GetPath() + "samp.exe", ipAddress + " " + serverPassword);
			return true;
		}
		catch {
			return false;
		}
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
	public bool CloseSA() {
		Process[] processes = Process.GetProcessesByName("gta_sa.exe");
		if (processes.Length > 0) {
		    processes[0].CloseMainWindow();
		    return true;
		}
		return false;
	}
}
