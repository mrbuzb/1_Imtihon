using G10_Bekmurod_Saidmurodov.Models;

namespace G10_Bekmurod_Saidmurodov.Services;

public class PhoneService
{
    private List<Phone> phones;

    public PhoneService()
    {
        phones = new List<Phone>();
    }

    public Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();

        phones.Add(phone);

        return phone;
    }


    public Phone GetByID(Guid id)
    {
        foreach (var phone in phones)
        {
            if (phone.Id == id)
            {
                return phone;
            }
        }

        return null;
    }


    public bool DeletePhone(Guid id)
    {
        var phoneById = GetByID(id);

        if (phoneById is null)
        {
            return false;
        }

        phones.Remove(phoneById);

        return true;
    }


    public bool UpdatePhone(Phone phone)
    {
        var phoneById = GetByID(phone.Id);

        if (phoneById is null)
        {
            return false;
        }

        phones[phones.IndexOf(phoneById)] = phone;

        return true;
    }


    public List<Phone> GetAllPhones()
    {
        return phones;
    }
}
