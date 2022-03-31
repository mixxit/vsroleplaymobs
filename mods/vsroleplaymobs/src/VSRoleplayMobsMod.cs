using System;
using System.Drawing;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Datastructures;
using Vintagestory.API.MathTools;
using Vintagestory.API.Server;

namespace vsroleplaymobds.src
{
    public class VSRoleplayMobsMod : ModSystem
    {
        private ICoreServerAPI csapi;

        public override void StartPre(ICoreAPI api)
        {
            base.StartPre(api);
        }

        public override bool ShouldLoad(EnumAppSide side)
        {
            return true;
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            this.csapi = api;
            base.StartServerSide(api);
            api.Event.PlayerNowPlaying += new PlayerDelegate(OnPlayerNowPlaying);
            
        }

        private void OnPlayerNowPlaying(IServerPlayer byPlayer)
        {
            //
        }

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
        }

        public override double ExecuteOrder()
        {
            /// Worldgen:
            /// - GenTerra: 0 
            /// - RockStrata: 0.1
            /// - Deposits: 0.2
            /// - Caves: 0.3
            /// - Blocklayers: 0.4
            /// Asset Loading
            /// - Json Overrides loader: 0.05
            /// - Load hardcoded mantle block: 0.1
            /// - Block and Item Loader: 0.2
            /// - Recipes (Smithing, Knapping, Clayforming, Grid recipes, Alloys) Loader: 1
            /// 
            return 1.1;
        }
    }
}
