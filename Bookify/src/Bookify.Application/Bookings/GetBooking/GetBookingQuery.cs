using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;
using Bookify.Domain.Bookings;

namespace Bookify.Application.Bookings.GetBooking;

public record GetBookingQuery(Guid BookingId): IQuery<BookingResponse>;