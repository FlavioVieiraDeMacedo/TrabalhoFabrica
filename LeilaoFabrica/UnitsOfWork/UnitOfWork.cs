using LeilaoFabrica.Models;
using LeilaoFabrica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeilaoFabrica.UnitsOfWork
{
    public class UnitOfWork
    {
        #region FIELDS
        private LeilaoContext _context = new LeilaoContext();

        private IGenericRepository<Usuario> _usuarioRepository;
        private IGenericRepository<Produto> _produtoRepository;
        private IGenericRepository<Leilao> _leilaoRepository;
        private IGenericRepository<Fornecedor> _fornecedorRepository;

        #endregion

        #region GETS

        public IGenericRepository<Fornecedor> FornecedorRepository
        {
            get
            {
                if(_fornecedorRepository == null)
                {
                    _fornecedorRepository = new GenericRepository<Fornecedor>(_context);
                }
                return _fornecedorRepository;
            }
            set { _fornecedorRepository = value; }
        }


        public IGenericRepository<Leilao> LeilaoRepository
        {
            get
            {
                if(_leilaoRepository == null)
                {
                    _leilaoRepository = new GenericRepository<Leilao>(_context);
                }
                return _leilaoRepository;
            }
            set { _leilaoRepository = value; }
        }


        public IGenericRepository<Produto> ProdutoRepository
        {
            get
            {
                if(_produtoRepository == null)
                {
                    _produtoRepository = new GenericRepository<Produto>(_context);
                }
                return _produtoRepository;
            }
            set { _produtoRepository = value; }
        }


        public IGenericRepository<Usuario> UsuarioRepository
        {
            get
            {
                if(_usuarioRepository == null)
                {
                    _usuarioRepository = new GenericRepository<Usuario>(_context);
                }
                return _usuarioRepository;             
            }
            set { _usuarioRepository = value; }
        }

        #endregion

        #region DISPOSE

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        #endregion

        #region SAVE

        public void Save()
        {
            _context.SaveChanges();
        }

        #endregion

    }
}