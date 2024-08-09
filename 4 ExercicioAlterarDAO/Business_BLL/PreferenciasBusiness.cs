﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using FACADE;


namespace Business_BLL
{
    public class PreferenciasBusiness
    {
        StreamReader objLeitor;
        string strLinhaDoArquivo;

        PreferenciasFD objPreferenciasFD;

        public List<String> impTxtWhile()
        {

            try
            {
                List<String> lista = new List<string>();
                objLeitor = new StreamReader(@"C:\Curso programar\C#\Preferencias\importar texto.txt");
                strLinhaDoArquivo = objLeitor.ReadLine();

                while (strLinhaDoArquivo != null)
                {
                    lista.Add(strLinhaDoArquivo);
                    strLinhaDoArquivo = objLeitor.ReadLine();
                }                
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
            finally
            {
                objLeitor.Close();
            }
            
        }

        public List<String> impBdConect()
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.impBdConect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public List<String> impBdDesconect()
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.impBdDesconect();
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public DataTable consultarBd(string strDescricao)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.consultarBd(strDescricao);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool inserirBd(string strParPreferencias)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.inserirBd(strParPreferencias);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool excluirBd(string strParDelPreferencias)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.excluirBd(strParDelPreferencias);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

        public bool alterarBd(string strParValorNovo, string strParValorAntigo)
        {
            try
            {
                objPreferenciasFD = new PreferenciasFD();
                return objPreferenciasFD.alterarBd(strParValorNovo, strParValorAntigo);
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECULTAR" + ex);
            }
        }

    }
}