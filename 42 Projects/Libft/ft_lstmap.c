/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstmap.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:42:14 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:42:36 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

t_list	*ft_lstmap(t_list *list, void *(*f)(void *), void (*del)(void *))
{
	t_list	*new;
	t_list	*temp;

	temp = ft_lstnew(f(list->content));
	new = temp;
	if (!list && !del)
		return (NULL);
	while (list->next)
	{
		list = list->next;
		if (!(temp->next = ft_lstnew(f(list->content))))
		{
			ft_lstdelone(temp->next, del);
			return (NULL);
		}
		temp = temp->next;
	}
	return (new);
}
