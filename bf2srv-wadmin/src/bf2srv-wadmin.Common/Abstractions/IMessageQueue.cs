using System;
using System.Collections.Generic;
using bf2srv-wadmin.Common.Communication;

namespace bf2srv-wadmin.Common.Abstractions;

public interface IMessageQueue<in TSend, TReceive>
{
    event EventHandler<MessageEventArgs<TReceive>> Receive;
    IEnumerable<TReceive> ReceiveAll();
    void Send(TSend message);
    void Dispose();
}