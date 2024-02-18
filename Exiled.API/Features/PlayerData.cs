// -----------------------------------------------------------------------
// <copyright file="PlayerData.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Features
{
    using System.Collections.Generic;
    using System.Linq;

    using Exiled.API.Enums;
    using Exiled.API.Features.Items;
    using Exiled.API.Features.Roles;
    using UnityEngine;

    /// <summary>
    /// Useful class to save Player.
    /// </summary>
    public class PlayerData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerData"/> class.
        /// </summary>
        /// <param name="player">Get all the information of the player>.</param>
        public PlayerData(Player player)
        {
            Role = player.Role;
            Health = player.Health;
            Position = player.Position;
            Items = player.Items.ToList();
            Ammo = player.Ammo;
        }

        /// <summary>
        /// Gets or sets the role saved for the Player.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Gets or sets the health saved for the player.
        /// </summary>
        public float Health { get; set; }

        /// <summary>
        /// Gets or sets the position saved for the player.
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// Gets or sets the items saved for the player.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the ammo saved for the player.
        /// </summary>
        public Dictionary<ItemType, ushort> Ammo { get; set; }
    }
}