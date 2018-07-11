﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stutton.DocumentCreator.Fields;
using Stutton.DocumentCreator.Shared;

namespace Stutton.DocumentCreator.ViewModels.Documents.Steps
{
    public class FieldsStepViewModel : Observable
    {
        private ObservableCollection<FieldDocumentModelBase> _fields;

        public ObservableCollection<FieldDocumentModelBase> Fields
        {
            get => _fields;
            set => Set(ref _fields, value);
        }

        public FieldsStepViewModel(IEnumerable<FieldDocumentModelBase> fields)
        {
            _fields = new ObservableCollection<FieldDocumentModelBase>(fields);
        }
    }
}
