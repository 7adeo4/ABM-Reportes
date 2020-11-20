using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ComplejoCinesGaray
{
    class Datos
    {
        OleDbConnection miConexion;
        OleDbCommand miComando;
        OleDbDataReader lector;
        string cadenaConexion;

        public Datos()
        {
            miConexion = new OleDbConnection();
            miComando = new OleDbCommand();
            cadenaConexion = null;
            lector = null;
        }

        public Datos(string miCadena)
        {

            miConexion = new OleDbConnection(miCadena);
            miComando = new OleDbCommand();
            lector = null;
        }

        public OleDbDataReader pLector { get => lector; set => lector = value; }
        public string pMiCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }

        public void Conectar()
        {
            miConexion.ConnectionString = @"Provider=SQLNCLI11;Data Source=DESKTOP-AA674QA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY";
            //Agus: Provider=SQLNCLI11;Data Source=DESKTOP-9DRKLNF;Integrated Security=SSPI;Initial Catalog=CineGARAY
            //Facu: Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY44
            //FAFU: Provider=SQLNCLI11;Data Source=DESKTOP-VVK62F7;Integrated Security=SSPI;Initial Catalog=CineGARAY
            miConexion.Open();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            miConexion.Close();
            miConexion.Dispose();
        }

        public void LeerTabla(string nombreTabla)
        {
            Conectar();
            miComando.CommandText = "select * from " + nombreTabla;
            lector = miComando.ExecuteReader();
        }

        public DataTable CargarTabla(string nombreTabla)
        {
            Conectar();
            DataTable tabla = new DataTable();
            miComando.CommandText = "select * from " + nombreTabla;
            tabla.Load(miComando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public void Actualizar(string consultaSQL)
        {
            Conectar();
            miComando.CommandText = consultaSQL;
            miComando.ExecuteNonQuery();
            Desconectar();
        }

        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            Conectar();
            miComando.CommandText = consultaSQL;


            tabla.Load(miComando.ExecuteReader());
            Desconectar();
            return tabla;

        }
    }
}
