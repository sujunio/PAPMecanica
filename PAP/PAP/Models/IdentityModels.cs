﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PAP.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<BaseModels.Automovel> Automovels { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<BaseModels.CondicaoPagamento> CondicaoPagamentoes { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Embalagem> Embalagems { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Estoque> Estoques { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Produto> Produtoes { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Servico> Servicoes { get; set; }

        public System.Data.Entity.DbSet<BaseModels.TipoDefeito> TipoDefeitoes { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<BaseModels.Venda> Vendas { get; set; }

        public System.Data.Entity.DbSet<BaseModels.ItemVenda> ItemVendas { get; set; }
    }
}