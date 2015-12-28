﻿using System.Linq;

namespace LHAL.WebAPI.DAL
{
    public class DataAccess : IDataAccess
    {
        private readonly LHAL_AppEntities _context = new LHAL_AppEntities();

        public IQueryable<Giocatore> GetPlayers()
        {
            return _context.Giocatore;
        }

        public IQueryable<Stagione> GetSeasons()
        {
            return _context.Stagione;
        }

        public IQueryable<Squadra> GetTeams()
        {
            return _context.Squadra;
        }

        public IQueryable<Squadra> GetTeams(int seasonID)
        {
            return _context.Squadra.Where(x => x.Rosa.Any(r => r.IDStagione == seasonID));
        }
    }
}