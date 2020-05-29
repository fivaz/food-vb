namespace WindowsFormsApp2.shared
{
    interface FormAdd<T>
    {
        T Build();
        void Edit();
        void Create();
        void SetEditMode();
        void ClearForm();
    }
}
