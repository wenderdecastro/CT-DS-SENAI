﻿using apiweb.eventplus.manha.Contexts;
using apiweb.eventplus.manha.Domains;
using apiweb.eventplus.manha.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apiweb.eventplus.manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _eventContext;

        public EventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Evento evento)
        {
            Evento eventoAntigo = BuscarPorId(id);

            if (eventoAntigo != null)
            {
                eventoAntigo.IdTipoEvento   = evento.IdTipoEvento;
                eventoAntigo.IdInstituicao  = evento.IdInstituicao;
                eventoAntigo.DataEvento     = evento.DataEvento;
                eventoAntigo.Descricao      = evento.Descricao;
                eventoAntigo.NomeEvento     = evento.NomeEvento;

                _eventContext.Evento.Update(eventoAntigo);
                _eventContext.SaveChanges();
            }
        }

        public Evento BuscarPorId(Guid id)
        {
            Evento eventoBuscado = _eventContext.Evento.FirstOrDefault(z => z.IdEvento == id)!;

            if (eventoBuscado != null)
            {
                return eventoBuscado;
            }

            return null!;

        }

        public void Cadastrar(Evento evento)
        {
            if (evento != null)
            {
                _eventContext.Evento.Add(evento);
                _eventContext.SaveChanges();
            }

        }

        public void Delete(Guid id)
        {
            Evento eventoDeletado = BuscarPorId(id);

            if (eventoDeletado != null)
            {
                _eventContext.Evento.Remove(eventoDeletado);
                _eventContext.SaveChanges();
            }


        }

        public List<Evento> Listar()
        {
            return _eventContext.Evento.Select(z => new Evento
            {
                IdEvento = z.IdEvento,
                DataEvento = z.DataEvento,
                NomeEvento = z.NomeEvento,
                Descricao = z.Descricao,
                IdInstituicao = z.IdInstituicao,
                IdTipoEvento = z.IdTipoEvento,
                TipoEvento = new TipoEvento
                {
                    Titulo = z.TipoEvento.Titulo,
                    IdTipoEvento = z.TipoEvento.IdTipoEvento
                },
                Instituicao = new Instituicao
                {
                    NomeFantasia = z.Instituicao.NomeFantasia
                }
            }).ToList();
        }

        public List<Evento> ListarProximos()
        {
            return _eventContext.Evento.Where(z => z.DataEvento > DateTime.Now).ToList();
        }
        public List<Evento> ListarAnteriores()
        {
            return _eventContext.Evento.Where(z => z.DataEvento < DateTime.Now).ToList();
        }
    }
}
