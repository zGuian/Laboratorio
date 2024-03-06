using Lab_Application.Interfaces;
using Lab_Domain.Entities;
using Lab_Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Lab_Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDataContext _context;
        private readonly ISqlDataAcess _dataAcess;
        private bool disposedValue;

        public UsuarioRepository(AppDataContext context, ISqlDataAcess dataAcess)
        {
            _context = context;
            _dataAcess = dataAcess;
        }

        public async Task<Usuario> BuscarAsync(string login)
        {
            var userData = await _context.Usuarios.FirstOrDefaultAsync(x => x.Chave == login);
            if (userData != null)
            {
                return userData;
            }
            else
            {
                throw new Exception();
            }
        }

        public async Task<IEnumerable<Usuario>> BuscarAsync()
        {
            return await _dataAcess.LoadData<Usuario, dynamic>("[dbo].[Onsite-User_GetAll]", new { });
        }

        public async Task<Usuario> BuscarAsync(int id)
        {
            var userData = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (userData != null)
            {
                return userData;
            }
            else
            {
                throw new Exception();
            }
        }

        public async Task<Usuario> AdicionarAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> AtualizarAsync(int id, Usuario usuario)
        {
            var usuarioId = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (usuarioId != null)
            {
                _context.Update(usuarioId).CurrentValues.SetValues(usuario);
                await _context.SaveChangesAsync();
                return usuarioId;
            }
            else
            {
                throw new Exception();
            }
        }

        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UsuarioRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
