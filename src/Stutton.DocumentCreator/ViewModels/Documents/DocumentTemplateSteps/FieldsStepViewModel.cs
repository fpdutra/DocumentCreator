﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Stutton.DocumentCreator.Models.Documents.Fields;
using Stutton.DocumentCreator.Services.Fields;
using Stutton.DocumentCreator.Shared;

namespace Stutton.DocumentCreator.ViewModels.Documents.DocumentTemplateSteps
{
    public class FieldsStepViewModel : Observable
    {
        private readonly IFieldFactoryService _fieldFactoryService;
        public ObservableCollection<IField> Fields { get; } = new ObservableCollection<IField>();

        public ObservableCollection<string> AvailableFieldTypes
        {
            get => _availableFieldTypes;
            set => Set(ref _availableFieldTypes, value);
        }

        #region ICommand AddFieldCommand

        private ICommand _addFieldCommand;
        public ICommand AddFieldCommand => _addFieldCommand ?? (_addFieldCommand = new RelayCommand(AddField));

        private void AddField()
        {
            
        }

        #endregion

        #region ICommand DeleteFieldCommand

        private ICommand _deleteFieldCommand;
        private ObservableCollection<string> _availableFieldTypes;
        public ICommand DeleteFieldCommand => _deleteFieldCommand ?? (_deleteFieldCommand = new RelayCommand<IField>(DeleteField));

        private void DeleteField(IField field)
        {
            
        }

        #endregion
        
        public FieldsStepViewModel(IFieldFactoryService fieldFactoryService)
        {
            _fieldFactoryService = fieldFactoryService;
        }

        public async Task InitializeAsync()
        {
            var fieldsResponse = await _fieldFactoryService.GetAllFieldKeys();
            
        }
    }
}
