using lolzin.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolzin.Model
{
  public  class Mapas
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        public Conexao con;

        public Mapas()
        {
            con = new Conexao();
        }

        public void Criar()
        {
            try
            {
                con.ExecutarComando($"INSERT INTO `mapa`(`codigo`, `nome`) VALUES  (null,'{nome}')");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de cadastrar uma planta " + e.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return con.ExecutarConsulta($"SELECT * FROM `mapa`");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de listar as Mapas " + e.Message);
            }
        }

        public void Editar()
        {
            try
            {
                con.ExecutarComando($"UPDATE `mapa` SET `nome` = '{nome}' WHERE codigo = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de ediar as Mapas " + e.Message);
            }
        }

        public void Deletar(string codigo)
        {
            try
            {
                con.ExecutarComando($"DELETE FROM `mapa` WHERE `codigo` = '{codigo}'");
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro na hora de deletar uma planta " + e.Message);
            }
        }
    }
}
