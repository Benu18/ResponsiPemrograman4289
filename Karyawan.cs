using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4289
{
	internal class Karyawan
	{
		public int No { get; set; }
		public string Nik { get; set; }
		public string Nama { get; set; }
		public double GajiBulanan { get; set; }
		public Karyawan(int _No, string _Nik, string _Nama, double _GajiBulanan)
		{
			No = _No;
			Nik = _Nik;
			Nama = _Nama;
			GajiBulanan = _GajiBulanan;
			if (GajiBulanan < 0)
			{
				Console.WriteLine("Gaji bulanan tidak boleh kurang dari 0");
				GajiBulanan = 0;
			}
		}
	}
}


