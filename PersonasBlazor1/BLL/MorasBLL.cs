using Microsoft.EntityFrameworkCore;
using PersonasBlazor1.DAL;
using PersonasBlazor1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PersonasBlazor1.BLL
{
    public class MorasBLL
    {
        public static bool Guardar(Moras mora)
        {

            if (!Existe(mora.MoraId))

                return Insertar(mora);

            else

                return Modificar(mora);
        }



        private static bool Insertar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Moras.Add(mora);
                paso = contexto.SaveChanges() > 0;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Moras mora)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM MorasDetalle Where MoraId = {mora.MoraId}");

                foreach (var item in mora.MoraDetalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(mora).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminado = contexto.Moras.Find(id);

                if (eliminado != null)
                {
                    contexto.Moras.Remove(eliminado);
                    paso = contexto.SaveChanges() > 0;
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return paso;
        }



        public static Moras Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Moras mora;

            try
            {
                mora = contexto.Moras
                    .Where(e => e.MoraId == id)
                    .Include(e => e.MoraDetalle)
                    .FirstOrDefault();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return mora;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Moras.Any(e => e.MoraId == id);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<Moras> GetList(Expression<Func<Moras, bool>> mora)
        {
            List<Moras> lista = new List<Moras>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Moras.Where(mora).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Moras> GetList()
        {
            List<Moras> lista = new List<Moras>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Moras.ToList();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return lista;

        }
    }
}
