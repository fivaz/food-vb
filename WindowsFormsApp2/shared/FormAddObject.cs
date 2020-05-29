namespace WindowsFormsApp2.shared
{
    interface FormAddObject<T>
    {
        T Build();
        void Edit();
        void Create();
        void SetEditMode();
        void ClearForm();
    }
}
