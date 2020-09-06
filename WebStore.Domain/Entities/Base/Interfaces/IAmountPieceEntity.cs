using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities.Base.Interfaces
{
    public interface IAmountPieceEntity : IBaseEntity
    {
        int AmountPiece { get; set; }
    }
}
