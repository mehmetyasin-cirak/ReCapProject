﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _iColorDal;

        public ColorManager(IColorDal iColorDal)
        {
            _iColorDal = iColorDal;
        }

        public IResult Add(Color color)
        {
            _iColorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_iColorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_iColorDal.Get(c => c.ColorId == colorId));
        }

        public IResult Remove(Color color)
        {
            _iColorDal.Delete(color);
            return new SuccessResult(Messages.RemovedColor);
        }

        public IResult Update(Color color)
        {
            _iColorDal.Update(color);
            return new SuccessResult(Messages.UpdatedColor);
        }


    }
}
