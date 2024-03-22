using AutoMapper;
using RentACar.DtoLayer.DTOs.BrandDtos;
using RentACar.DtoLayer.DTOs.CarDetailDtos;
using RentACar.DtoLayer.DTOs.CarDtos;
using RentACar.DtoLayer.DTOs.CarFeatureDtos;
using RentACar.DtoLayer.DTOs.CarStatusDtos;
using RentACar.DtoLayer.DTOs.CategoryDtos;
using RentACar.DtoLayer.DTOs.ContactDtos;
using RentACar.DtoLayer.DTOs.LocationDtos;
using RentACar.DtoLayer.DTOs.MessageDtos;
using RentACar.DtoLayer.DTOs.ReviewDtos;
using RentACar.DtoLayer.DTOs.ServiceDtos;
using RentACar.DtoLayer.DTOs.TestimonialDtos;
using RentACar.EntityLayer.Concrete;

namespace RentACar.PresentationLayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CarDto, Car>().ReverseMap();
            CreateMap<MessageDto, Message>().ReverseMap();
            CreateMap<BrandDto, Brand>().ReverseMap();
            CreateMap<CarStatusDto, CarStatus>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<LocationDto, Location>().ReverseMap();
            CreateMap<CarDetailDto, CarDetail>().ReverseMap();
            CreateMap<ContactDto, Contact>().ReverseMap();
            CreateMap<ServiceDto, Service>().ReverseMap();
            CreateMap<TestimonialDto, Testimonial>().ReverseMap();
            CreateMap<ReviewDto, Review>().ReverseMap();
            CreateMap<CarFeatureDto, CarFeature>().ReverseMap();
        }
    }
}
