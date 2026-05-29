using Application.Interfaces;
using Domain.Entities;
using Infrastructrure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructrure.Command
{
    public class DescuentoCommand : IDescuentoCommand
    {
        private readonly TemplateContext _context;

        public DescuentoCommand(TemplateContext context)
        {
            _context = context;
        }

        public async Task<Descuento> CrearDescuento(Descuento descuento)
        {
            await _context.Descuentos.AddAsync(descuento);
            await _context.SaveChangesAsync();
            return descuento;
        }

        public async Task<Descuento> ModificarDescuento(Descuento descuento)
        {
            _context.Descuentos.Update(descuento);
            await _context.SaveChangesAsync();
            return descuento;
        }

        public async Task<Descuento> EliminarDescuento(Descuento descuento)
        {
            _context.Descuentos.Remove(descuento);
            await _context.SaveChangesAsync();
            return descuento;
        }
    }
}
