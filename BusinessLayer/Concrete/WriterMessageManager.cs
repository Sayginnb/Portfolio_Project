﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public void TAdd(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetListbyFilter(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == p).ToList();
        }

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUptade(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}