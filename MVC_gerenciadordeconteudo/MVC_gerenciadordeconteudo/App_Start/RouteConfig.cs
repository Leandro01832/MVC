using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_gerenciadordeconteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

            routes.MapRoute(
                "visualisar",
                "visualizar",
                new { controller = "Home", action = "Index" }
           );

            routes.MapRoute(
              "sobre",
              "sobre",
              new { controller = "Home", action = "About" }
         );

            routes.MapRoute(
           "biblia",
           "biblia",
           new { controller = "biblia", action = "Index"}
      );

            routes.MapRoute(
         "biblia_capitulo",
         "biblia/{nome}/capitulo",
         new { controller = "biblia", action = "capitulo", nome = "" }
    );

            routes.MapRoute(
     "biblia_capitulo_versiculo_2",
     "biblia/{nome}/{capitulo}",
     new { controller = "biblia", action = "versiculo", nome = "", capitulo = 0 }
);

            routes.MapRoute(
       "biblia_capitulo_versiculo",
       "biblia/{nome}/{capitulo}/versiculo",
       new { controller = "biblia", action = "versiculo", nome = "", capitulo = 0 }
  );

            routes.MapRoute(
              "pessoas",
              "pessoas",
              new { controller = "pessoas", action = "Index" }
         );

            routes.MapRoute(
              "pessoas_visitante",
              "pessoas/visitante",
              new { controller = "pessoas", action = "visitante" }
         );

            routes.MapRoute(
           "pessoas_criar_visitante",
           "pessoas/criar_visitante",
           new { controller = "pessoas", action = "Criar_visitante" }
      );

            routes.MapRoute(
            "pessoas_crianca",
            "pessoas/crianca",
            new { controller = "pessoas", action = "crianca" }
       );

            routes.MapRoute(
          "pessoas_criar_crianca",
          "pessoas/criar_crianca",
          new { controller = "pessoas", action = "Criar_crianca" }
     );

            routes.MapRoute(
          "pessoas_membro_batismo",
          "pessoas/membro_batismo",
          new { controller = "pessoas", action = "membro_batismo" }
     );

            routes.MapRoute(
        "pessoas_criar_membro_batismo",
        "pessoas/criar_membro_batismo",
        new { controller = "pessoas", action = "criar_membro_batismo" }
   );

            routes.MapRoute(
       "pessoas_membro_transferencia",
       "pessoas/membro_transferencia",
       new { controller = "pessoas", action = "membro_transferencia" }
  );

            routes.MapRoute(
       "pessoas_criar_membro_transferencia",
       "pessoas/criar_membro_transferencia",
       new { controller = "pessoas", action = "criar_membro_transferencia" }
  );

            routes.MapRoute(
     "pessoas_membro_aclamacao",
     "pessoas/membro_aclamacao",
     new { controller = "pessoas", action = "membro_aclamacao" }
);

            routes.MapRoute(
      "pessoas_criar_membro_aclamacao",
      "pessoas/criar_membro_aclamacao",
      new { controller = "pessoas", action = "criar_membro_aclamacao" }
 );

            routes.MapRoute(
     "pessoas_membro_reconciliacao",
     "pessoas/membro_reconciliacao",
     new { controller = "pessoas", action = "membro_reconciliacao" }
);

            routes.MapRoute(
      "pessoas_criar_membro_reconciliacao",
      "pessoas/criar_membro_reconciliacao",
      new { controller = "pessoas", action = "criar_membro_reconciliacao" }
 );

            routes.MapRoute(
      "pessoas_id_editar",
      "pessoas/{id}/editar",
      new { controller = "pessoas", action = "editar", id = 0 }
 );

            routes.MapRoute(
     "pessoas_id_alterar",
     "pessoas/{id}/alterar",
     new { controller = "pessoas", action = "alterar", id = 0 }
);

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "contact" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
