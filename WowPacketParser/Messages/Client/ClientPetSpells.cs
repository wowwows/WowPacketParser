using System.Collections.Generic;
using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientPetSpells
    {
        public ulong PetGUID;
        public ushort CreatureFamily;
        public ushort Specialization;
        public uint TimeLimit;
        public uint PetModeAndOrders;
        public List<uint> Actions;
        public List<PetSpellCooldown> Cooldowns;
        public List<PetSpellHistory> SpellHistory;
        public fixed uint ActionButtons[10];
    }}