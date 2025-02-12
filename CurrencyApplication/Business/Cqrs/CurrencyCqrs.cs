using CurrencyApi.Base.Response;
using MediatR;
using Schema.Request;

namespace Business.Cqrs;

public record GetAllSupportedCurrencies : IRequest<ApiResponse<CurrencyResponse>>;
public record ConvertCurrency(ConvertCurrencyRequest Model) : IRequest<ApiResponse<ConvertCurrencyResponse>>;
public record MultipleCurrencyRates(ConvertMultipleCurrencyRequest Model) : IRequest<ApiResponse<ConvertMultipleCurrencyResponse>>;
