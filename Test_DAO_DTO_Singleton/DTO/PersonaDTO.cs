using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_DAO_DTO_Singleton.DTO
{
    class PersonaDTO
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private DateTime fecha_nacimiento;

		public DateTime Fecha_Nacimiento
		{
			get { return fecha_nacimiento; }
			set { fecha_nacimiento = value; }
		}


	}
}
