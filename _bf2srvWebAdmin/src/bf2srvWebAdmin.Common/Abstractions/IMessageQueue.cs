using System;
using System.Collections.Generic;
using bf2srvWebAdmin.Common.Communication;

namespace bf2srvWebAdmin.Common.Abstractions;

public interface IMessageQueue<in TSend, TReceive>
{
    event EventHandler<MessageEventArgs<TReceive>> Receive;
    IEnumerable<TReceive> ReceiveAll();
    void Send(TSend message);
    void Dispose();
}