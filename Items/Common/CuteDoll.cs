using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerRoguelike.TerPlayer;

namespace TerRoguelike.Items.Common
{
    public class AmberBead : BaseRoguelikeItem, ILocalizedModType
    {
      //changed: name
        public override int modItemID => ModContent.ItemType<CuteDoll>();
        public override bool HealingItem => false;
        public override bool UtilityItem => true;
        public override int itemTier => 0;
        public override float ItemDropWeight => 0.5f;
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = Item.CommonMaxStack;
        }
        public override void ItemEffects(Player player)
        {
            player.GetModPlayer<TerRoguelikePlayer>().cuteDoll += Item.stack;
        }
    }
}
