using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeBlog.Models
{
    public class Blog
    {
        public List<Post> posts = new List<Post>();

        public void AgregarPost(Post post)
        {
            posts.Add(post);
        }
        public void ModificarPost(int id,Post post)
        {
            this.BorrarPost(posts.Find(x => x.Id == id));
            posts.Add(post);
        }
        public void BorrarPost(Post post)
        {
            posts.Remove(post);
        }
        public Post BuscarPorId(int id)
        {
            return posts.Find(x=>x.Id==id);
        }
        public List<Post> retornarLista()
        {
             return (List<Post>)(posts.OrderByDescending(x => x.FechaDeCreacion));
        }

    }
}
