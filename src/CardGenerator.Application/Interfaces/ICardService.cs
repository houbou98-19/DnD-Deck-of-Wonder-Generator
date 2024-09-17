using CardGenerator.Application.DTO;

namespace CardGenerator.Application.Interfaces
{
    public interface ICardService
    {
        CardDTO DrawCard();
    }
}