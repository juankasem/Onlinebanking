using MediatR;
using OnlineBanking.Application.Models;

namespace OnlineBanking.Application.Features.CreditCards.Commands;

public class DeactivateCreditCardCommand : IRequest<ApiResult<Unit>>
{
    public string CreditCardNo { get; set; }
}