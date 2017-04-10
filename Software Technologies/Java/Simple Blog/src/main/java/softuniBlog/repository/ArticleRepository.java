package softuniBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import softuniBlog.entity.Article;

public interface ArticleRepository extends JpaRepository<Article, Integer> {
}
