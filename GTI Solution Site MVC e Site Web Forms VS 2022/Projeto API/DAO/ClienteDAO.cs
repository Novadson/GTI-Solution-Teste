using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_API.DataServices;
using Projeto_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_API.DAO
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteDAO : ControllerBase
    {
        #region VARIABLES
        private readonly IDbContextFactory<ApplicationContext> _contextFactory;
        private Cliente cliente = new();
        #endregion VARIABLES

        #region CONSTRUCTOR 
        public ClienteDAO(IDbContextFactory<ApplicationContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        #endregion CONSTRUCTOR 

        #region GET ASYNC
        [HttpGet, Route("GetAsync")]
        public async Task<Cliente> GetAsync(Guid IdCliente)
        {
            using (ApplicationContext _context = _contextFactory.CreateDbContext())
            {
                cliente = await _context.Cliente.Where(c => c.IdCliente.Equals(IdCliente)).FirstOrDefaultAsync();
                if (cliente!=null)
                cliente.Endereco = GetById(IdCliente);
                return cliente;
            }

        }

        [HttpGet, Route("GetAsyncByCpf")]
        public async Task<Cliente> GetAsyncByCpf(string Cpf)
        {
            using (ApplicationContext _context = _contextFactory.CreateDbContext())
            {
                cliente = await _context.Cliente.Where(c => c.Cpf.Equals(Cpf)).FirstOrDefaultAsync();
                if (cliente != null)
                    cliente.Endereco = GetById(cliente.IdCliente);
                return cliente;
            }

        }


        [ApiExplorerSettings(IgnoreApi = true)]/*HIDDEN THIS METHOD FORM SWAGGER*/
        public EnderecoCliente GetById(Guid IdCliente)
        {
            using (ApplicationContext _context = _contextFactory.CreateDbContext())
                return _context.EnderecoCliente.FirstOrDefault(e => e.IdCliente.Equals(IdCliente));

        }
        #endregion GETASYNC


        #region  GET LIST ASYNC
        [HttpGet, Route("GetListAsync")]
        public List<Cliente> GetListAsync()
        {
            using (ApplicationContext _context = _contextFactory.CreateDbContext())
            {
                var query = (from cliente in _context.Cliente
                             orderby cliente.Nome
                             select cliente).ToList();
                query.ForEach(x =>
                {
                    x.Endereco = GetById(x.IdCliente);
                });
                return query;
            }
        }

        #endregion GET LIST ASYNC


        #region SAVE OR UPDATE
        [HttpPost, Route("SaveOrUpdate")]
        public void SaveOrUpdate(Cliente Cliente)
        {
            try
            {
                using (ApplicationContext _context = _contextFactory.CreateDbContext())
                {
                    if (Cliente.IdCliente != Guid.Empty)
                        _context.Cliente.Update(Cliente);
                    else
                        _context.Cliente.Add(Cliente);
                    _context.SaveChanges();
                    Cliente.Endereco.IdCliente = Cliente.IdCliente;
                    SaveOrUpdateDepency(Cliente);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        #endregion

        #region SAVE OR UPDATE
        [ApiExplorerSettings(IgnoreApi = true)]/*HIDDEN THIS METHOD FROM SWAGGER*/
        public bool SaveOrUpdateDepency(Cliente Cliente)
        {
            try
            {
                using (ApplicationContext _context = _contextFactory.CreateDbContext())
                {
                    EnderecoCliente EnderecoCliente = GetById(Cliente.IdCliente);
                    if (EnderecoCliente != null)
                        _context.EnderecoCliente.Update(Cliente.Endereco);
                    else
                        _context.EnderecoCliente.Add(Cliente.Endereco);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion SAVEORUPDATE


        #region REMOVE
        [HttpDelete, Route("Remove")]
        public void Remove(Guid IDCliente)
        {
            try
            {
                using (ApplicationContext _context = _contextFactory.CreateDbContext())
                {
                    Cliente cliente = _context.Cliente.Where(e => e.IdCliente.Equals(IDCliente)).Include(e => e.Endereco).First();
                    _context.Cliente.Remove(cliente);
                    _context.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion REMOVE
    }


}
