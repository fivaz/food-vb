namespace WindowsFormsApp2.shared
{
    interface FormAdd<T>
    {
        T Build();
        void ClearForm();
        void Create();
        void Edit();
        void SetEditMode();
    }
}
