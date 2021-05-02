/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   libft.h                                            :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:51:11 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 12:52:28 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef LIBFT_H
# define LIBFT_H

# include <unistd.h>
# include <stdlib.h>
# include <string.h>

typedef struct	s_list
{
	void			*content;
	struct s_list	*next;
}				t_list;

int				ft_strncmp(const char *s1, const char *s2, size_t n);
int				ft_atoi(const char *str);
int				ft_isalnum(int i);
int				ft_isalpha(int i);
int				ft_isascii(int i);
int				ft_isdigit(int i);
int				ft_tolower(int i);
int				ft_toupper(int i);
int				ft_isprint(int c);
int				ft_memcmp(const void *s1, const void *s2, size_t size);
int				ft_lstsize(t_list *list);
char			*ft_strnstr(const char *hay, const char *ned, size_t len);
char			**ft_split(const char *s, char c);
char			*ft_strjoin(const char *s1, const char *s2);
char			*ft_strchr(const char *str, int c);
char			*ft_strdup(const char *str);
char			*ft_strrchr(const char *str, int c);
char			*ft_substr(const char *s, unsigned int start, size_t len);
char			*ft_strtrim(const char *s1, const char *set);
char			*ft_strmapi(const char *s, char (*f)(unsigned int, char));
char			*ft_itoa(int n);
char			*ft_substr(const char *s, unsigned int start, size_t len);
void			*ft_memset(void *str, int i, size_t size);
void			*ft_memcpy(void *dest, const void *src, size_t size);
void			*ft_memchr(const void *str, int c, size_t size);
void			*ft_memmove(const void *dest, const void *src, size_t size);
void			*ft_memccpy(void *dest, const void *src, int c, size_t size);
void			ft_putchar_fd(char s, int fd);
void			ft_putendl_fd(char *str, int fd);
void			ft_putstr_fd(char *str, int fd);
void			ft_putnbr_fd(int nb, int fd);
void			*ft_bzero(void *str, size_t size);
void			*ft_calloc(size_t count, size_t size);
void			ft_lstadd_front(t_list **list, t_list *new);
void			ft_lstadd_back(t_list **lst, t_list *new);
void			ft_lstiter(t_list *list, void (*f)(void *));
void			ft_lstdelone(t_list *list, void (*del)(void *));
void			ft_lstclear(t_list **list, void (*del)(void *));
size_t			ft_strlcpy(char *dest, const char *src, size_t size);
size_t			ft_strlen(const char *str);
size_t			ft_strlcat(char *dest, const char *src, size_t size);
t_list			*ft_lstlast(t_list *list);
t_list			*ft_lstnew(void *algo);
t_list			*ft_lstmap(t_list *list, void *(*f)(void *),
					void (*del)(void *));
#endif
