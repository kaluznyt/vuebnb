namespace vuebnb.Models {
    public class GenericViewModel<Model> {
        public Model Data { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Metadata {
        public string Path { get; set; }
    }
}