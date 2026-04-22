using PackagingRecordVideoApplication.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PackagingRecordVideoApplication.Services
{
    public class PackingSessionService
    {
        private PackingSessionRepository _instance;

        public PackingSessionService()
        {
            _instance = new PackingSessionRepository();
        }

        public DataTable GetAllSessions()
        {
            return _instance.GetAllSessions();
        }

        public void InsertSession(string barcode, string videoPath)
        {
            _instance.InsertSession(barcode, videoPath);
        }

        public bool IsBarcodeExists(string barcode)
        {
            return _instance.IsBarcodeExists(barcode);
        }
    }
}