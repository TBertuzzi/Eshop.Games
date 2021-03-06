﻿using Eshop.Games.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Games.Services
{
    internal interface INintendoService
    {
        Task<NintendoGame> GetGames(int index,int limit, Order order);
        Task<NintendoGameDetail> GetGameDetail(string slug);
    }
}
