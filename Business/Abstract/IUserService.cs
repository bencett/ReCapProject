﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByBrandId(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
