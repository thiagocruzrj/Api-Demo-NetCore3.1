using SalesSystem.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.Business.Notifications
{
    public class Notificador : INotificador
    {
        private readonly List<Notificacao> _notificacoes;

        public Notificador(List<Notificacao> notificacoes)
        {
            _notificacoes = notificacoes;
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
