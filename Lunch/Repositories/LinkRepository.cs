using Lunch.Data;
using Lunch.Interfaces;
using Lunch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Repositories
{
    public class LinkRepository : IAllLinks
    {
        private readonly ApplicationDbContext appDBContent;

        public LinkRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Link> Links => appDBContent.Links.Include(p => p.place);

        public Link getObjectLink(int linkId) => appDBContent.Links.FirstOrDefault(p => p.id == linkId);
    }
}
