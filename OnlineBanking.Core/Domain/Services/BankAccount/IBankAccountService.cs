
using OnlineBanking.Core.Domain.Aggregates.BankAccountAggregate;
using OnlineBanking.Core.Domain.Aggregates.CustomerAggregate;

namespace OnlineBanking.Core.Domain.Services.BankAccount;

public interface IBankAccountService
{
    bool CreateCashTransaction(Aggregates.BankAccountAggregate.BankAccount senderAccount, Aggregates.BankAccountAggregate.BankAccount recipientAccount, Guid cashTransactionId, decimal amount);

    bool CreateFastTransaction(Aggregates.BankAccountAggregate.BankAccount bankAccount, FastTransaction fastTransaction);

    bool CreateCustomer(Aggregates.BankAccountAggregate.BankAccount bankAccount, Customer customer);
}