﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using JetBrains.Annotations;
using Abp.Extensions;

namespace Abp.RealTime
{
    /// <summary>
    /// Extension methods for <see cref="IOnlineClientManager"/>.
    /// </summary>
    public static class OnlineClientManagerExtensions
    {
        /// <summary>
        /// Determines whether the specified user is online or not.
        /// </summary>
        /// <param name="onlineClientManager">The online client manager.</param>
        /// <param name="user">User.</param>
        public static bool IsOnline(
            [NotNull] this IOnlineClientManager onlineClientManager,
            [NotNull] UserIdentifier user)
        {
            return onlineClientManager.GetAllByUserId(user).Any();
        }

        public static bool Remove(
            [NotNull] this IOnlineClientManager onlineClientManager,
            [NotNull] IOnlineClient client)
        {
            onlineClientManager.CheckNotNull(nameof(onlineClientManager));
            client.CheckNotNull(nameof(client));

            return onlineClientManager.Remove(client.ConnectionId);
        }
    }
}