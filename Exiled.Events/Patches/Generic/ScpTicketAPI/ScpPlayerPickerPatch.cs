namespace Exiled.Events.Patches.Generic.ScpTicketAPI
{
    using System.Collections.Generic;

    using HarmonyLib;
    using PlayerRoles.RoleAssign;

    /// <summary>
    /// Patches <see cref="ScpPlayerPicker"/> to create a ScpTicket API.
    /// </summary>
    [HarmonyPatch(typeof(ScpPlayerPicker))]
    internal static class ScpPlayerPickerPatch
    {
        private static bool ChoosePlayers(int targetScps, List<ReferenceHub> __result)
        {
            return false;
        }
    }
}