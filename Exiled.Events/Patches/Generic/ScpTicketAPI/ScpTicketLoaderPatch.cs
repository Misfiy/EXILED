namespace Exiled.Events.Patches.Generic.ScpTicketAPI
{
    using HarmonyLib;
    using PlayerRoles.RoleAssign;

    /// <summary>
    /// Patches stuff needed for custom Scp Tickets.
    /// </summary>
    [HarmonyPatch(typeof(ScpTicketsLoader))]
    internal static class ScpTicketLoaderPatch
    {
    }
}