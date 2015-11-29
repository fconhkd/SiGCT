using NHibernate;
using System;
using System.Web;

namespace SiGCT.Models.DAO
{
    /// <summary>
    /// Implements the Open-Session-In-View pattern using <see cref="NHibernateSessionManager" />.
    /// Assumes that each HTTP request is given a single transaction for the entire page-lifecycle.
    /// Inspiration for this class came from Ed Courtenay at 
    /// http://sourceforge.net/forum/message.php?msg_id=2847509.
    /// </summary>
    public class NHibernateSessionModule : IHttpModule
    {
        public void Init(System.Web.HttpApplication context)
        {
            context.BeginRequest += new EventHandler(BeginTransaction);
            context.EndRequest += new EventHandler(CommitAndCloseSession);
        }

        /// <summary>
        /// Opens a session within a transaction at the beginning of the HTTP request.
        /// This doesn't actually open a connection to the database until needed.
        /// </summary>
        private void BeginTransaction(object sender, EventArgs e)
        {
            ISession session = NHibernateSessionManager.OpenSession();
            NHibernateSessionManager.Session = session;
        }

        /// <summary>
        /// Commits and closes the NHibernate session provided by the supplied <see cref="NHibernateSessionManager"/>.
        /// Assumes a transaction was begun at the beginning of the request; but a transaction or session does
        /// not *have* to be opened for this to operate successfully.
        /// </summary>
        private void CommitAndCloseSession(object sender, EventArgs e)
        {
            ISession session = NHibernateSessionManager.Session;
            session.Flush();
            if (session.Transaction != null && session.Transaction.IsActive)
                session.Transaction.Commit();
            session.Close();
            NHibernateSessionManager.Session = null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }


}
