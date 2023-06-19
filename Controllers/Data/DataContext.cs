using Microsoft.EntityFrameworkCore;
using FuncionalidadeTCC.Models;

namespace FuncionalidadeTCC.Controllers.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData
            (
                new Usuario() { id = 0},
            new Usuario() {Cpf = 123456789 , id = 1 , senha = " 123@" , nome = "Fabia", email = "fabia@etec.com" },
            new Usuario() {Cpf = 987654321 , id = 2 , senha = " 321@" , nome = "Allan", email = "Allan@etec.com" },
            new Usuario() {Cpf = 222222222 , id = 3 , senha = " 456." , nome = "Kaleb", email = "Kaleb@etec.com" },
            new Usuario() {Cpf = 435575688 , id = 4 , senha = " 54367@" , nome = "Henrique", email = "Henrique@etec.com" },
            new Usuario() {Cpf = 456789234 , id = 5 , senha = " 25657654!" , nome = "Gumesi", email = "gumesi@etec.com" }
            );

            Cadastrante user = new Cadastrante();
            user.Id = 1;
            user.Username = "UsuarioAbc";
            user.Perfil = "Abc";
            user.Email ="seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;
            user.PasswordHash = null;
            user.PasswordSalt = null;
            user.Foto = null;


        }
    }
}
