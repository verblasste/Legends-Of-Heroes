﻿using System.Collections.Generic;
using System.Linq;

namespace ET.Server
{
	[ComponentOf(typeof(Scene))]
	public class PlayerComponent : Entity, IAwake, IDestroy
	{
		public Dictionary<string, EntityRef<Player>> dictionary = new Dictionary<string, EntityRef<Player>>();
        public readonly Dictionary<long, EntityRef<Player>> idPlayers = new Dictionary<long, EntityRef<Player>>();
    }
}