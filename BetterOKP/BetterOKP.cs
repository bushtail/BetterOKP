using JetBrains.Annotations;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Enums;
using SPTarkov.Server.Core.Models.Spt.Tables;
using SPTarkov.Server.Core.Services;

namespace BetterOKP;

[Injectable(TypePriority = OnLoadOrder.TraderRegistration - 1), UsedImplicitly]
public class BetterOKP(TemplateTable templateTable) : IOnLoad
{
    public Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var items = templateTable.Items;
        items[ItemTpl.COLLIMATOR_OKP7_REFLEX_SIGHT].Properties!.Prefab = new Prefab
        {
            Path = "scope_all_ekb_okp7_chevron.bundle",
            Rcid = ""
        };
        return Task.CompletedTask;
    }
}