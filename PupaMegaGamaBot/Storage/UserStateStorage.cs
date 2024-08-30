﻿using PupaMegaGamaBot.User;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupaMegaGamaBot.Storage
{
    public class UserStateStorage
    {
        private readonly ConcurrentDictionary<long, UserState> cache = new ConcurrentDictionary<long, UserState>();

        public void AddOrUpdate(long telegramUserId, UserState userState)
        {
            cache.AddOrUpdate(telegramUserId, userState, (x, y) => userState);
        }

        public bool TryGet(long telegramUserId, out UserState? userState)
        {
            return cache.TryGetValue(telegramUserId, out userState);
        }
    }
}
