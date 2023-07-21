using GerenciadorPecasPC.Model;
using GerenciadorPecasPC.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPecasPC.Controller
{
    internal class ManipulaPecas
    {
        public void CadPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pcadastrarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades", Pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("idpecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();


                var resposta = MessageBox.Show("Peça cadastrada com sucesso , Deseja cadastrar outra Peça?",
                    "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    viewpecas viewpecas = new viewpecas();
                    viewpecas.AbrirCadastrado();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BuscaPecasCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["idPecas"]);
                    Pecas.Marca = (string)registros["Marcas"];
                    Pecas.Peca = (string)registros["Pecas"];
                    Pecas.Capacidade = (string)registros["Capacidades"];
                }
                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisar Código");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();



                var resposta = MessageBox.Show("Peça deletada com sucesso, Deseja outra Peça?",
                    "Deletar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    deletarpeca del = new deletarpeca();
                    del.AbrirDeletar();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void AlterarPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidade", Pecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça alterada com Sucesso.");
                
                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade = "";

            }
            catch (Exception)
            {
                throw;
            }
        }

    }

}

